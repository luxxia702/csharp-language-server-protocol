using MediatR;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using OmniSharp.Extensions.JsonRpc;

namespace OmniSharp.Extensions.LanguageServer.Protocol.Models
{
    /// <summary>
    ///  The parameters send in a will save text document notification.
    /// </summary>
    [Method(DocumentNames.WillSave)]
    public class WillSaveTextDocumentParams : IRequest
    {
        /// <summary>
        ///  The document that will be saved.
        /// </summary>
        public TextDocumentIdentifier TextDocument { get; set; }

        /// <summary>
        ///  The 'TextDocumentSaveReason'.
        /// </summary>
        public TextDocumentSaveReason Reason { get; set; }
    }
}
