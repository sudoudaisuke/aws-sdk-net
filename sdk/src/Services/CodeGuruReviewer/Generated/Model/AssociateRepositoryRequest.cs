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
 * Do not modify this file. This file is generated from the codeguru-reviewer-2019-09-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeGuruReviewer.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateRepository operation.
    /// Use to associate an AWS CodeCommit repository or a repostory managed by AWS CodeStar
    /// Connections with Amazon CodeGuru Reviewer. When you associate a repository, CodeGuru
    /// Reviewer reviews source code changes in the repository's pull requests and provides
    /// automatic recommendations. You can view recommendations using the CodeGuru Reviewer
    /// console. For more information, see <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-ug/recommendations.html">Recommendations
    /// in Amazon CodeGuru Reviewer</a> in the <i>Amazon CodeGuru Reviewer User Guide.</i>
    /// 
    /// 
    ///  
    /// <para>
    /// If you associate a CodeCommit repository, it must be in the same AWS Region and AWS
    /// account where its CodeGuru Reviewer code reviews are configured.
    /// </para>
    ///  
    /// <para>
    ///  Bitbucket and GitHub Enterprise Server repositories are managed by AWS CodeStar Connections
    /// to connect to CodeGuru Reviewer. For more information, see <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-ug/reviewer-ug/step-one.html#select-repository-source-provider">Connect
    /// to a repository source provider</a> in the <i>Amazon CodeGuru Reviewer User Guide.</i>
    /// 
    /// </para>
    ///  <note> 
    /// <para>
    ///  You cannot use the CodeGuru Reviewer SDK or the AWS CLI to associate a GitHub repository
    /// with Amazon CodeGuru Reviewer. To associate a GitHub repository, use the console.
    /// For more information, see <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-ug/getting-started-with-guru.html">Getting
    /// started with CodeGuru Reviewer</a> in the <i>CodeGuru Reviewer User Guide.</i> 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AssociateRepositoryRequest : AmazonCodeGuruReviewerRequest
    {
        private string _clientRequestToken;
        private Repository _repository;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request.
        /// </para>
        ///  
        /// <para>
        /// To add a new repository association, this parameter specifies a unique identifier
        /// for the new repository association that helps ensure idempotency.
        /// </para>
        ///  
        /// <para>
        /// If you use the AWS CLI or one of the AWS SDKs to call this operation, you can leave
        /// this parameter empty. The CLI or SDK generates a random UUID for you and includes
        /// that in the request. If you don't use the SDK and instead generate a raw HTTP request
        /// to the Secrets Manager service endpoint, you must generate a ClientRequestToken yourself
        /// for new versions and include that value in the request.
        /// </para>
        ///  
        /// <para>
        /// You typically interact with this value if you implement your own retry logic and want
        /// to ensure that a given repository association is not created twice. We recommend that
        /// you generate a UUID-type value to ensure uniqueness within the specified repository
        /// association.
        /// </para>
        ///  
        /// <para>
        /// Amazon CodeGuru Reviewer uses this value to prevent the accidental creation of duplicate
        /// repository associations if there are failures and retries. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property Repository. 
        /// <para>
        /// The repository to associate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Repository Repository
        {
            get { return this._repository; }
            set { this._repository = value; }
        }

        // Check to see if Repository property is set
        internal bool IsSetRepository()
        {
            return this._repository != null;
        }

    }
}