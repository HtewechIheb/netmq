using AsyncIO;

namespace NetMQ.Core
{
    /// <summary>
    /// Combines a peer socket with the identity received from it.
    /// </summary>
    public class SocketIdentity
    {
        /// <summary>
        /// The identity received from the peer socket.
        /// </summary>
        public byte[]? Identity { get; set; }
        /// <summary>
        /// The peer socket.
        /// </summary>
        public AsyncSocket? Socket { get; set; }

        /// <summary>
        /// Create a new SocketIdentity with the specified identity and socket.
        /// </summary>
        /// <param name="identity">The identity received from the peer socket.</param>
        /// <param name="socket">The peer socket.</param>
        public SocketIdentity(byte[] identity, AsyncSocket socket)
        {
            Identity = identity;
            Socket = socket;
        }
    }
}
