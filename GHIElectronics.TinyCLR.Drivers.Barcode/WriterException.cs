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

using System;

namespace GHIElectronics.TinyCLR.Drivers.Barcode
{
	/// <summary> A base class which covers the range of exceptions which may occur when encoding a barcode using
	/// the Writer framework.
	/// 
	/// </summary>
	/// <author>  dswitkin@google.com (Daniel Switkin)
	/// </author>
	/// <author>www.Redivivus.in (suraj.supekar@redivivus.in) - Ported from GHIElectronics.TinyCLR.Drivers.Barcode Java Source 
	/// </author>
	[Serializable]
	public sealed class WriterException : Exception
	{
		public WriterException()
		{
		}

      public WriterException(String message)
         :base(message)
		{
		}

      public WriterException(String message, Exception innerExc)
         : base(message, innerExc)
      {
      }
   }
}