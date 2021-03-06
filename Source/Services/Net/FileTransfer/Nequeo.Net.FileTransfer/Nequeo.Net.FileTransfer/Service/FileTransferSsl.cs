﻿/*  Company :       Nequeo Pty Ltd, http://www.nequeo.com.au/
 *  Copyright :     Copyright © Nequeo Pty Ltd 2014 http://www.nequeo.com.au/
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Nequeo.Net.FileTransfer.Service
{
    /// <summary>
    /// File stransfer service.
    /// </summary>
    partial class FileTransferSsl : ServiceBase
    {
        /// <summary>
        /// File stransfer service.
        /// </summary>
        public FileTransferSsl()
        {
            InitializeComponent();
            Initialise();
        }

        private Nequeo.Net.FileTransfer.Controller.FileTransferSslControl _fileTransferControl = null;

        /// <summary>
        /// Initialise
        /// </summary>
        private void Initialise()
        {
            // Start a new instance of the application controller.
            _fileTransferControl = new Nequeo.Net.FileTransfer.Controller.FileTransferSslControl();
        }

        /// <summary>
        /// On start.
        /// </summary>
        /// <param name="args">The application arguments.</param>
        protected override void OnStart(string[] args)
        {
            // If the object exists then start all
            // client threads.
            if (_fileTransferControl != null)
                _fileTransferControl.StartServerThreads();
        }

        /// <summary>
        /// On Stop.
        /// </summary>
        protected override void OnStop()
        {
            // If the object exists then stop all
            // client threads.
            if (_fileTransferControl != null)
                _fileTransferControl.StopServerThreads();
        }
    }
}
