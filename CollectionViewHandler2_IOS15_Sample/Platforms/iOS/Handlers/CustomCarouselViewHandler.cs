using System;
using CollectionViewHandler2_IOS15_Sample.Platforms.iOS.Controllers;
using Microsoft.Maui.Controls.Handlers.Items2;
using UIKit;

namespace CollectionViewHandler2_IOS15_Sample.Handlers;

public partial class CustomCarouselViewHandler : CarouselViewHandler2
{
    public CustomCarouselViewHandler() : base(Mapper) {}

    protected override CarouselViewController2 CreateController(CarouselView newElement, UICollectionViewLayout layout)
    {
        return new CustomCarouselViewController2(newElement, layout);
    }
}
