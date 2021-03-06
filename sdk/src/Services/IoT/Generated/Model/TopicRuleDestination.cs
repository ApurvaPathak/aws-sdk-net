/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// A topic rule destination.
    /// </summary>
    public partial class TopicRuleDestination
    {
        private string _arn;
        private HttpUrlDestinationProperties _httpUrlProperties;
        private TopicRuleDestinationStatus _status;
        private string _statusReason;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The topic rule destination URL.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property HttpUrlProperties. 
        /// <para>
        /// Properties of the HTTP URL.
        /// </para>
        /// </summary>
        public HttpUrlDestinationProperties HttpUrlProperties
        {
            get { return this._httpUrlProperties; }
            set { this._httpUrlProperties = value; }
        }

        // Check to see if HttpUrlProperties property is set
        internal bool IsSetHttpUrlProperties()
        {
            return this._httpUrlProperties != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the topic rule destination. Valid values are:
        /// </para>
        ///  <dl> <dt>IN_PROGRESS</dt> <dd> 
        /// <para>
        /// A topic rule destination was created but has not been confirmed. You can set <code>status</code>
        /// to <code>IN_PROGRESS</code> by calling <code>UpdateTopicRuleDestination</code>. Calling
        /// <code>UpdateTopicRuleDestination</code> causes a new confirmation challenge to be
        /// sent to your confirmation endpoint.
        /// </para>
        ///  </dd> <dt>ENABLED</dt> <dd> 
        /// <para>
        /// Confirmation was completed, and traffic to this destination is allowed. You can set
        /// <code>status</code> to <code>DISABLED</code> by calling <code>UpdateTopicRuleDestination</code>.
        /// </para>
        ///  </dd> <dt>DISABLED</dt> <dd> 
        /// <para>
        /// Confirmation was completed, and traffic to this destination is not allowed. You can
        /// set <code>status</code> to <code>ENABLED</code> by calling <code>UpdateTopicRuleDestination</code>.
        /// </para>
        ///  </dd> <dt>ERROR</dt> <dd> 
        /// <para>
        /// Confirmation could not be completed, for example if the confirmation timed out. You
        /// can call <code>GetTopicRuleDestination</code> for details about the error. You can
        /// set <code>status</code> to <code>IN_PROGRESS</code> by calling <code>UpdateTopicRuleDestination</code>.
        /// Calling <code>UpdateTopicRuleDestination</code> causes a new confirmation challenge
        /// to be sent to your confirmation endpoint.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public TopicRuleDestinationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Additional details or reason why the topic rule destination is in the current status.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

    }
}