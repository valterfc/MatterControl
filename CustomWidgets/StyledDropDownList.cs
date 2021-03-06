﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MatterHackers.Agg;
using MatterHackers.Agg.Image;
using MatterHackers.Agg.UI;
using MatterHackers.Agg.OpenGlGui;
using MatterHackers.PolygonMesh;
using MatterHackers.RenderOpenGl;
using MatterHackers.VectorMath;
using MatterHackers.Agg.VertexSource;

namespace MatterHackers.MatterControl
{
    public class StyledDropDownList : DropDownList
    {

        static RGBA_Bytes whiteSemiTransparent = new RGBA_Bytes(255, 255, 255, 100);
        static RGBA_Bytes whiteTransparent = new RGBA_Bytes(255, 255, 255, 0);
        
        public StyledDropDownList(string noSelectionString, Direction direction = Direction.Down)
            : base(noSelectionString, whiteTransparent, whiteSemiTransparent, direction)
        {   
            this.TextColor = ActiveTheme.Instance.PrimaryTextColor;
            this.MenuItemsBorderWidth = 1;
            this.MenuItemsBackgroundColor = RGBA_Bytes.White;
            this.MenuItemsBorderColor = ActiveTheme.Instance.PrimaryTextColor;
            this.MenuItemsPadding = new BorderDouble(10,8,10,12);
            this.MenuItemsBackgroundHoverColor = ActiveTheme.Instance.PrimaryAccentColor;
            this.MenuItemsTextHoverColor = ActiveTheme.Instance.PrimaryTextColor;
            this.BorderWidth = 1;
            this.BorderColor = whiteSemiTransparent;
            this.HoverColor = whiteSemiTransparent;
            this.BackgroundColor = new RGBA_Bytes(255, 255, 255, 0);
        }
    }
}
