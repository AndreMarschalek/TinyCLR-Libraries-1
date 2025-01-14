/*
* Copyright 2008 ZXing authors
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

namespace GHIElectronics.TinyCLR.Drivers.Barcode
{
   /// <summary>
   /// These are a set of hints that you may pass to Writers to specify their behavior.
   /// </summary>
   /// <author>  dswitkin@google.com (Daniel Switkin)
   /// </author>
   /// <author>www.Redivivus.in (suraj.supekar@redivivus.in) - Ported from GHIElectronics.TinyCLR.Drivers.Barcode Java Source 
   /// </author>
   public enum EncodeHintType
   {
      /// <summary>
      /// Specifies what degree of error correction to use, for example in QR Codes.
      /// Type depends on the encoder. For example for QR codes it's type
      /// {@link com.google.GHIElectronics.TinyCLR.Drivers.Barcode.qrcode.decoder.ErrorCorrectionLevel ErrorCorrectionLevel}.
      /// </summary>
      ERROR_CORRECTION,

      /// <summary>
      /// Specifies what character encoding to use where applicable (type {@link String})
      /// </summary>
      CHARACTER_SET,

      /// <summary>
      /// Specifies margin, in pixels, to use when generating the barcode. The meaning can vary
      /// by format; for example it controls margin before and after the barcode horizontally for
      /// most 1D formats. (Type {@link Integer}).
      /// </summary>
      MARGIN,

      /// <summary>
      /// Specifies whether to use compact mode for PDF417 (type {@link Boolean}).
      /// </summary>
      PDF417_COMPACT,

      /// <summary>
      /// Specifies what compaction mode to use for PDF417 (type
      /// {@link com.google.GHIElectronics.TinyCLR.Drivers.Barcode.pdf417.encoder.Compaction Compaction}).
      /// </summary>
      PDF417_COMPACTION,

      /// <summary>
      /// Specifies the minimum and maximum number of rows and columns for PDF417 (type
      /// {@link com.google.GHIElectronics.TinyCLR.Drivers.Barcode.pdf417.encoder.Dimensions Dimensions}).
      /// </summary>
      PDF417_DIMENSIONS,

      /// <summary>
      /// specifies if the slow algorithm of selecting an appropriate mask should be execute.
      /// if true it slow significantly down the process.
      /// default: false
      /// </summary>
      QR_DO_MASK_SELECTION
   }
}