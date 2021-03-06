using System.Threading.Tasks;
using OrchardCore.DisplayManagement;
using OrchardCore.DisplayManagement.ModelBinding;

namespace OrchardCore.ContentManagement.Display
{
    /// <summary>
    /// Describe services responsible for displaying a content item. The result dynamic objects
    /// are the Shape to render a <see cref="ContentItem"/>.
    /// </summary>
    public interface IContentItemDisplayManager
    {
        Task<IShape> BuildDisplayAsync(ContentItem content, IUpdateModel updater, string displayType = "", string groupId = "");
        Task<IShape> BuildEditorAsync(ContentItem content, IUpdateModel updater, string groupId = "", string htmlFieldPrefix = "");
        Task<IShape> UpdateEditorAsync(ContentItem content, IUpdateModel updater, string groupId = "", string htmlFieldPrefix = "");
    }
}