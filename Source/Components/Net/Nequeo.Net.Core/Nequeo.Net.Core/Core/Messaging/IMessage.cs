﻿/*  Company :       Nequeo Pty Ltd, http://www.nequeo.com.au/
 *  Copyright :     Copyright © Nequeo Pty Ltd 2012 http://www.nequeo.com.au/
 * 
 *  File :          
 *  Purpose :       
 * 
 */

#region Nequeo Pty Ltd License
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
#endregion


namespace Nequeo.Net.Core.Messaging
{
	using System;
	using System.Collections.Generic;
	using System.Diagnostics.Contracts;
	using System.Text;

	/// <summary>
	/// The interface that classes must implement to be serialized/deserialized
	/// as protocol or extension messages.
	/// </summary>
	[ContractClass(typeof(IMessageContract))]
	public interface IMessage {
		/// <summary>
		/// Gets the version of the protocol or extension this message is prepared to implement.
		/// </summary>
		/// <remarks>
		/// Implementations of this interface should ensure that this property never returns null.
		/// </remarks>
		Version Version { get; }

		/// <summary>
		/// Gets the extra, non-standard Protocol parameters included in the message.
		/// </summary>
		/// <remarks>
		/// Implementations of this interface should ensure that this property never returns null.
		/// </remarks>
		IDictionary<string, string> ExtraData { get; }

		/// <summary>
		/// Checks the message state for conformity to the protocol specification
		/// and throws an exception if the message is invalid.
		/// </summary>
		/// <remarks>
		/// <para>Some messages have required fields, or combinations of fields that must relate to each other
		/// in specialized ways.  After deserializing a message, this method checks the state of the 
		/// message to see if it conforms to the protocol.</para>
		/// <para>Note that this property should <i>not</i> check signatures or perform any state checks
		/// outside this scope of this particular message.</para>
		/// </remarks>
		/// <exception cref="ProtocolException">Thrown if the message is invalid.</exception>
		void EnsureValidMessage();
	}

	/// <summary>
	/// Code contract for the <see cref="IMessage"/> interface.
	/// </summary>
	[ContractClassFor(typeof(IMessage))]
    public abstract class IMessageContract : IMessage
    {
		/// <summary>
		/// Prevents a default instance of the <see cref="IMessageContract"/> class from being created.
		/// </summary>
		private IMessageContract() {
		}

		/// <summary>
		/// Gets the version of the protocol or extension this message is prepared to implement.
		/// </summary>
        public Version Version
        {
			get {
				Contract.Ensures(Contract.Result<Version>() != null);
				return default(Version); // dummy return
			}
		}

		/// <summary>
		/// Gets the extra, non-standard Protocol parameters included in the message.
		/// </summary>
		/// <value></value>
		/// <remarks>
		/// Implementations of this interface should ensure that this property never returns null.
		/// </remarks>
        public IDictionary<string, string> ExtraData
        {
			get {
				Contract.Ensures(Contract.Result<IDictionary<string, string>>() != null);
				return default(IDictionary<string, string>);
			}
		}

		/// <summary>
		/// Checks the message state for conformity to the protocol specification
		/// and throws an exception if the message is invalid.
		/// </summary>
		/// <remarks>
		/// 	<para>Some messages have required fields, or combinations of fields that must relate to each other
		/// in specialized ways.  After deserializing a message, this method checks the state of the
		/// message to see if it conforms to the protocol.</para>
		/// 	<para>Note that this property should <i>not</i> check signatures or perform any state checks
		/// outside this scope of this particular message.</para>
		/// </remarks>
		/// <exception cref="ProtocolException">Thrown if the message is invalid.</exception>
        public void EnsureValidMessage()
        {
		}
	}
}
