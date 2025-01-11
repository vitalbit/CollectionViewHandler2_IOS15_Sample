using System;
using CollectionViewHandler2_IOS15_Sample.Platforms.iOS.Controllers;
using Microsoft.Maui.Controls.Handlers.Items2;
using UIKit;

namespace CollectionViewHandler2_IOS15_Sample.Handlers;

public partial class CustomCollectionViewHandler : CollectionViewHandler2
{
    public CustomCollectionViewHandler() : base(Mapper) {}

    protected override ItemsViewController2<ReorderableItemsView> CreateController(ReorderableItemsView itemsView, UICollectionViewLayout layout)
    {
        return new CustomCollectionViewController2(itemsView, layout);
    }
}
