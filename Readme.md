# Wordiscover
Wordiscover is a Microsoft Word addin built in C# and the installer is available for download from http://wordiscover.cint.io.  I am open-sourcing it because I think it provides some valuable insight into (A) how to create a Word addin, (B) how to efficiently search Word documents, and (C) an easy insight into async in C#.

## Overview
Since this is a Winform app, the main logic extends from `FindPane.cs`.  Each section that lives on the Pane has its own `.cs` file - i.e., the Results area lives in `FindPane.Results.cs`.  The main search logic lives in `Finder.cs` and `FinderHelpers.cs`.

The idea behind the search algorithm is to search a `Word.Range` with a regular expression. Here's the idea... Each paragraph has a `Range` that has a beginning and ending position (`int`), and a `Text` property which contains the paragraph text.  

1. For a regular regex search, we simply search that `Text` for a match and return any matches
2. For a proximity regex search, we need to get the position of `currentParagraph.Range.Start` and extend our search to `currentParagraph+Proximity.Range.End`.  Then we create a `Word.Range` with those positions, grab the `Text` and search via regex again.


## Challenges
There were some interesting challenges I faced in making this addin as efficient as possible.  The biggest challenge was figuring out a way to even perform such expensive searches efficiently and deliver results asynchronously.

### Challenge 1: Proximity Searching with Regex
I first tried to proximity search with regular expressions themselves - this is really awful in terms of performance and also leads to [runaway regexes](http://www.regular-expressions.info/catastrophic.html).

The solution I came up with was to just grab paragraph start/end positions, create a `Word.Range` for them and search the range text.  This led to my next problem.

### Challenge 2: Iterating a Word Doc's Paragraphs object
My previous faillure led to this design, which follows this is idea:

1. For each paragraph, grab the ending position of the proximity-number's paragraph and store in a `List`.
2. When search begins, iterate (`i`) through each paragraph.  Set new `Word.Range` start to `currentParagraph.Start` and end to `List[i+ProxNumber]`.

I started out with a regular Parallel for-loop to iterate the paragraphs, just accessing each paragraph by index:  `paragraphs[i]`.  For some reason, and I have no idea why, the performance of this is terrible, terrible, terrible.

The solution?  To use an `Iterator`.  Counterintuitive as it is, using the paragraphs iterator and `Parallel.ForEach` helped to speed up the routine that grabs the ending position of every paragraph.  If you understand why this is faster than simply indexing in via a basic for-loop, please send me the explanation! :)

Alas, this method wasn't foolproof.  The problem was when to perform it.  On document load would be nice, but what if the user changes the document and by doing so, makes all of the ending positions in the `List` irrelevant?  So, we perform this every time the user clicks 'Proximity Search.' 

The other unfortunate part is that I couldn't get this routine to perform fast enough when operating asynchronously, so it is a sync method right now. (See `Finder.Proximity.cs`)


