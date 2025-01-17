﻿#region MigraDoc - Creating Documents on the Fly

//
// Authors:
//   Klaus Potzesny
//
// Copyright (c) 2001-2019 empira Software GmbH, Cologne Area (Germany)
//
// http://www.pdfsharp.com
// http://www.migradoc.com
// http://sourceforge.net/projects/pdfsharp
//
// Permission is hereby granted, free of charge, to any person obtaining a
// copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included
// in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
// DEALINGS IN THE SOFTWARE.

#endregion

using System;
using System.Diagnostics;
using System.Reflection;
using System.IO;
using PdfSharp.Drawing;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.RtfRendering.Resources;

namespace MigraDoc.RtfRendering
{
    /// <summary>
    ///   Render an image to RTF.
    /// </summary>
    internal class BarcodeRenderer : ShapeRenderer
    {
        internal BarcodeRenderer(DocumentObject domObj, RtfDocumentRenderer docRenderer)
            : base(domObj, docRenderer)
        {
            _barcode = domObj as Barcode;
        }

        /// <summary>
        ///   Renders a barcode to RTF.
        /// </summary>
        internal override void Render()
        {            
            Debug.WriteLine(Messages2.BarcodeNotSupported(_barcode.Code), "warning");            
        }

        /// <summary>
        ///   Renders image specific attributes and the image byte series to RTF.
        /// </summary>
        private void RenderBarcode()
        {
        }

        
        protected override Unit GetShapeHeight()
        {
            return Unit.Empty;
        }


        protected override Unit GetShapeWidth()
        {
            return Unit.Empty;
        }


        private readonly Barcode _barcode;
    }
}