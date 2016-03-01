// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace visma
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    public static partial class AttachmentExtensions
    {
            /// <summary>
            /// Get latest revision of a specific Attachment
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='attachmentId'>
            /// Identifies the attachment
            /// </param>
            public static void Get(this IAttachment operations, string attachmentId)
            {
                Task.Factory.StartNew(s => ((IAttachment)s).GetAsync(attachmentId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get latest revision of a specific Attachment
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='attachmentId'>
            /// Identifies the attachment
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GetAsync( this IAttachment operations, string attachmentId, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.GetWithHttpMessagesAsync(attachmentId, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Update a specific Attachment
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='attachmentId'>
            /// Identifies the Attachment to update
            /// </param>
            /// <param name='metadataDto'>
            /// Defines the data for the Attachment to update
            /// </param>
            public static void Put(this IAttachment operations, string attachmentId, AttachmentMetadataUpdateDto metadataDto)
            {
                Task.Factory.StartNew(s => ((IAttachment)s).PutAsync(attachmentId, metadataDto), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a specific Attachment
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='attachmentId'>
            /// Identifies the Attachment to update
            /// </param>
            /// <param name='metadataDto'>
            /// Defines the data for the Attachment to update
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutAsync( this IAttachment operations, string attachmentId, AttachmentMetadataUpdateDto metadataDto, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PutWithHttpMessagesAsync(attachmentId, metadataDto, null, cancellationToken).ConfigureAwait(false);
            }

    }
}
