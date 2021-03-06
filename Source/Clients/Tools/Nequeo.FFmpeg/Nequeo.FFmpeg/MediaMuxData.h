/* Company :       Nequeo Pty Ltd, http://www.nequeo.com.au/
*  Copyright :     Copyright � Nequeo Pty Ltd 2016 http://www.nequeo.com.au/
*
*  File :          MediaMuxData.h
*  Purpose :       MediaMuxData class.
*
*/

/*
Permission is hereby granted, free of charge, to any person
obtaining a copy of this software and associated documentation
files (the "Software"), to deal in the Software without
restriction, including without limitation the rights to use,
copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the
Software is furnished to do so, subject to the following
conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
OTHER DEALINGS IN THE SOFTWARE.
*/

#pragma once

#ifndef _MEDIAMUXDATA_H
#define _MEDIAMUXDATA_H

#include "stdafx.h"

#include "MediaMuxDataNative.h"

using namespace System;
using namespace System::Drawing;
using namespace System::Drawing::Imaging;

namespace Nequeo
{
	namespace Media
	{
		namespace FFmpeg
		{
			/// <summary>
			/// A structure to encapsulate all FFMPEG related private variable.
			/// </summary>
			public ref struct MediaMuxData
			{
			public:
				/// <summary>
				/// A structure to encapsulate all FFMPEG related private variable.
				/// </summary>
				MediaMuxData()
				{
					FormatContext = NULL;
					AudioCodec = NULL;
					VideoCodec = NULL;
					OutputFormat = NULL;
					Dictionary = NULL;

					VideoStream = NULL;
					AudioStream = NULL;

					Have_Video = 0;
					Have_Audio = 0;
					Encode_Video = 0;
					Encode_Audio = 0;
				}

				libffmpeg::OutputStream* VideoStream;
				libffmpeg::OutputStream* AudioStream;

				libffmpeg::AVFormatContext* FormatContext;
				libffmpeg::AVCodec* AudioCodec;
				libffmpeg::AVCodec* VideoCodec;
				libffmpeg::AVOutputFormat* OutputFormat;
				libffmpeg::AVDictionary* Dictionary;

				int Have_Video;
				int Have_Audio;
				int Encode_Video;
				int Encode_Audio;
			};
		}
	}
}
#endif