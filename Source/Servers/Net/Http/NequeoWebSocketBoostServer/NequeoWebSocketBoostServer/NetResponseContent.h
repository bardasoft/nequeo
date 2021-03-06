/* Company :       Nequeo Pty Ltd, http://www.nequeo.com.au/
*  Copyright :     Copyright � Nequeo Pty Ltd 2016 http://www.nequeo.com.au/
*
*  File :          NetResponseContent.h
*  Purpose :       WebSocket net response content class.
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

#include "stdafx.h"
#include "Global.h"

namespace Nequeo {
	namespace Net {
		namespace WebSocket
		{
			/// <summary>
			/// WebSocket net response content.
			/// </summary>
			class EXPORT_NEQUEO_WEBSOCKET_BOOST_SERVER_API NetResponseContent
			{
			public:
				/// <summary>
				/// WebSocket net response content.
				/// </summary>
				NetResponseContent() {}

				/// <summary>
				/// WebSocket net response content.
				/// </summary>
				~NetResponseContent() {}

				/// <summary>
				/// Get the headers.
				/// </summary>
				/// <return>The headers.</return>
				inline const std::map<std::string, std::string>& GetHeaders() const
				{
					return _headers;
				}

				/// <summary>
				/// Set the headers.
				/// </summary>
				/// <param name="headers">The headers.</param>
				inline void SetHeaders(std::map<std::string, std::string>& headers)
				{
					_headers = headers;
				}

				/// <summary>
				/// Get the protocol version.
				/// </summary>
				/// <return>The protocol version.</return>
				inline const std::string& GetProtocolVersion() const
				{
					return _protocolVersion;
				}

				/// <summary>
				/// Set the protocol version.
				/// </summary>
				/// <param name="protocolVersion">The protocol version.</param>
				inline void SetProtocolVersion(const std::string& protocolVersion)
				{
					_protocolVersion = protocolVersion;
				}

			private:
				std::map<std::string, std::string> _headers;
				std::string _protocolVersion;
			};
		}
	}
}