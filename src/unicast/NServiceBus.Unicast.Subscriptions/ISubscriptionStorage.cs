using System.Collections.Generic;
using NServiceBus.Unicast.Transport;

namespace NServiceBus.Unicast.Subscriptions
{
	/// <summary>
	/// Defines storage for subscriptions
	/// </summary>
    public interface ISubscriptionStorage
    {
        /// <summary>
        /// Check to see if <see cref="msg"/> is a <see cref="SubscriptionMessage"/>.
        /// If so, performs the relevant subscribe/unsubscribe.
        /// </summary>
        /// <param name="msg">The message received in the bus.</param>
        /// <returns>True if <see cref="msg"/> is a <see cref="SubscriptionMessage"/>.</returns>
	    bool HandledSubscriptionMessage(TransportMessage msg);

        /// <summary>
        /// Returns a list of addresses of subscribers that previously requested to be notified
        /// of messages of the same type as <see cref="message"/>.
        /// </summary>
        /// <param name="message">The logical message that the bus wishes to publish.</param>
        /// <returns>List of addresses of subscribers.</returns>
        IList<string> GetSubscribersForMessage(IMessage message);

        /// <summary>
        /// Notifies the subscription storage that now is the time to perform
        /// any initialization work
        /// </summary>
	    void Init();
    }
}
