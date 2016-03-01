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

    public static partial class VismanetAPIExtensions
    {
            /// <summary>
            /// Test connection
            /// </summary>
            /// Returns "OK" as plain text if the test connection succeded.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static string TestConnection(this IVismanetAPI operations)
            {
                return Task.Factory.StartNew(s => ((IVismanetAPI)s).TestConnectionAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Test connection
            /// </summary>
            /// Returns "OK" as plain text if the test connection succeded.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> TestConnectionAsync( this IVismanetAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.TestConnectionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get security token using credentials.
            /// </summary>
            /// Issue token for the client based on provided User Credentials
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static void GetSecurityToken(this IVismanetAPI operations, UserCredentials body = default(UserCredentials))
            {
                Task.Factory.StartNew(s => ((IVismanetAPI)s).GetSecurityTokenAsync(body), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get security token using credentials.
            /// </summary>
            /// Issue token for the client based on provided User Credentials
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GetSecurityTokenAsync( this IVismanetAPI operations, UserCredentials body = default(UserCredentials), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.GetSecurityTokenWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false);
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='authorization'>
            /// </param>
            public static void RevokeSecurityToken(this IVismanetAPI operations, string authorization = default(string))
            {
                Task.Factory.StartNew(s => ((IVismanetAPI)s).RevokeSecurityTokenAsync(authorization), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='authorization'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task RevokeSecurityTokenAsync( this IVismanetAPI operations, string authorization = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.RevokeSecurityTokenWithHttpMessagesAsync(authorization, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get the companies available for this token.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='authorization'>
            /// </param>
            public static IList<ContextInformation> GetAvailableUserContexts(this IVismanetAPI operations, string authorization = default(string))
            {
                return Task.Factory.StartNew(s => ((IVismanetAPI)s).GetAvailableUserContextsAsync(authorization), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the companies available for this token.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='authorization'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<ContextInformation>> GetAvailableUserContextsAsync( this IVismanetAPI operations, string authorization = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAvailableUserContextsWithHttpMessagesAsync(authorization, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Obtain access token
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='grantType'>
            /// Grant type. Possible values for this parameter include: 'password'
            /// </param>
            /// <param name='username'>
            /// Visma.net user email
            /// </param>
            /// <param name='password'>
            /// Visma.net password
            /// </param>
            /// <param name='authorization'>
            /// HTTP Basic authentication, the preffered way to authenticate clients
            /// </param>
            /// <param name='clientId'>
            /// Client identifier. Mandatory to be set when no other HTTP authentication
            /// was used. For instance, a client can also use Authorization header to
            /// pass HTTP Basic authentication details
            /// </param>
            /// <param name='clientSecret'>
            /// Client secret. Mandatory to be set only when no other HTTP authentication
            /// was set.
            /// </param>
            public static void Token(this IVismanetAPI operations, string grantType, string username, string password, string authorization = default(string), string clientId = default(string), string clientSecret = default(string))
            {
                Task.Factory.StartNew(s => ((IVismanetAPI)s).TokenAsync(grantType, username, password, authorization, clientId, clientSecret), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Obtain access token
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='grantType'>
            /// Grant type. Possible values for this parameter include: 'password'
            /// </param>
            /// <param name='username'>
            /// Visma.net user email
            /// </param>
            /// <param name='password'>
            /// Visma.net password
            /// </param>
            /// <param name='authorization'>
            /// HTTP Basic authentication, the preffered way to authenticate clients
            /// </param>
            /// <param name='clientId'>
            /// Client identifier. Mandatory to be set when no other HTTP authentication
            /// was used. For instance, a client can also use Authorization header to
            /// pass HTTP Basic authentication details
            /// </param>
            /// <param name='clientSecret'>
            /// Client secret. Mandatory to be set only when no other HTTP authentication
            /// was set.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task TokenAsync( this IVismanetAPI operations, string grantType, string username, string password, string authorization = default(string), string clientId = default(string), string clientSecret = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.TokenWithHttpMessagesAsync(grantType, username, password, authorization, clientId, clientSecret, null, cancellationToken).ConfigureAwait(false);
            }

    }
}
