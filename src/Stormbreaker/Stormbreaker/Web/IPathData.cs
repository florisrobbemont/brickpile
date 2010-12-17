using Stormbreaker.Models;

namespace Stormbreaker.Web {
    public interface IPathData {
        string Action { get; set; }
        string Controller { get; set; }
        IDocument CurrentDocument { get; set; }
    }
}