# MigraDoc
MigraDoc Foundation - Creating documents on the fly

MigraDoc references PDFsharp as a submodule. After pulling MigraDoc to a local repository, call
* git submodule init
* git submodule update

to update the submodule.

When forking MigraDoc, the fork will still reference the original PDFsharp repository. Consider forking PDFsharp, too, and use your fork as a submodule.

When downloading MigraDoc as a ZIP, the submodule PDFsharp will be empty. So also download a ZIP for the PDFsharp repository.

Please note: Source code is also available on SourceForge as a ZIP file. The MigraDoc ZIP file on SourceForge does include the PDFsharp files.

# Resources

The official project web site:  
http://pdfsharp.net/

The official peer-to-peer support forum:  
http://forum.pdfsharp.net/

# Release Notes for PDFsharp/MigraDoc 1.50 (stable)

The stable version of PDFsharp 1.32 was published in 2013.  
So a new stable version is long overdue.

I really hope the stable version does not have any regressions versus 1.50 beta 3b or later.

And I hope there are no regressions versus version 1.32 stable. But several bugs have been fixed.  
There are a few breaking changes that require code updates.

To use PDFsharp with Medium Trust you have to get the source code and make some changes. The NuGet packages do not support Medium Trust.  
Azure servers do not require Medium Trust.

I'm afraid that many users who never tried any beta version of PDFsharp 1.50 will now switch from version 1.32 stable to version 1.50 stable.  
Nothing wrong about that. I hope we don't get an avalanche of bug reports now.

# Changes by NXTwoThou 8/28/2019

MigraDoc will now set PageWidth/PageHeight if they are Empty when PapeFormat is set.  See https://github.com/empira/MigraDoc/issues/26
AddBarcode support to MIgraDoc based on the work presented https://forum.pdfsharp.net/viewtopic.php?t=1215
MigraDoc Fixed table indent when LeftPadding set
PDFSharp can now use streams that are unable to seek(Like Response.Outputstream in asp.net)  https://github.com/empira/PDFsharp/issues/102
PDFSharp now has PdfDocument.Options.EnableXmp.  When set false it won't export the XML metadata giving smaller file sizes to better compete with iTextSharp.



