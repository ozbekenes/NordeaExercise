I develop this task with technology ASP.NET WebAPI / ASP.NET Core.

The basic requirement is to provide a program that can convert text into either XML format-ted data or comma separated (CSV) data. The text is to be parsed, broken into sentences and words and the words have to be sorted.

###############################################################################################

The program must be able to input text like:

"Mary had a little lamb. Peter called for the wolf, and Aesop came. 
Cinderella likes shoes."

and parse this text into relevant model classes, and be able to convert the structure to both XML and CSV format.


The parsing must break the text into sentences and words. The parser should allow some whitespace around words and delimiters, e.g. the following is allowed as input and should produce the same result as the first example:

"  Mary   had a little  lamb  . 


  Peter   called for the wolf   ,  and Aesop came .
 Cinderella  likes shoes."


###############################################################################################

In both cases the XML result should be like:
<?xml version="1.0" encoding="UTF-8" standalone="yes"?>
<text>
    <sentence>
        <word>a</word>
        <word>had</word>
        <word>lamb</word>
        <word>little</word>
        <word>Mary</word>
    </sentence>
    <sentence>
        <word>Aesop</word>
        <word>and</word>
        <word>called</word>
        <word>came</word>
        <word>for</word>
        <word>Peter</word>
        <word>the</word>
        <word>wolf</word>
    </sentence>
    <sentence>
        <word>Cinderella</word>
        <word>likes</word>
        <word>shoes</word>
    </sentence>
</text>

And the CSV result should likewise be:
, Word 1, Word 2, Word 3, Word 4, Word 5, Word 6, Word 7, Word 8
Sentence 1, a, had, lamb, little, Mary
Sentence 2, Aesop, and, called, came, for, Peter, the, wolf
Sentence 3, Cinderella, likes, shoes

