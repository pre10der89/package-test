﻿/**
 * Copyright (c) 2014-present, Facebook, Inc.
 * All rights reserved.
 *
 * This source code is licensed under the BSD-style license found in the
 * LICENSE file in the root directory of this source tree. An additional grant
 * of patent rights can be found in the PATENTS file in the same directory.
 */

using System;

namespace Facebook.Yoga
{
    public partial class YogaNode
    {
        public static YogaNode Create(
            YogaDirection? styleDirection = null,
            YogaFlexDirection? flexDirection = null,
            YogaJustify? justifyContent = null,
            YogaAlign? alignContent = null,
            YogaAlign? alignItems = null,
            YogaAlign? alignSelf = null,
            YogaPositionType? positionType = null,
            YogaWrap? wrap = null,
            YogaOverflow? overflow = null,
            float? flex = null,
            float? flexGrow = null,
            float? flexShrink = null,
            float? flexBasis = null,
            Spacing position = null,
            Spacing margin = null,
            Spacing padding = null,
            Spacing border = null,
            float? width = null,
            float? height = null,
            float? maxWidth = null,
            float? maxHeight = null,
            float? minWidth = null,
            float? minHeight = null)
        {
            YogaNode node = new YogaNode();

            if (styleDirection.HasValue)
            {
                node.StyleDirection = styleDirection.Value;
            }

            if (flexDirection.HasValue)
            {
                node.FlexDirection = flexDirection.Value;
            }

            if (justifyContent.HasValue)
            {
                node.JustifyContent = justifyContent.Value;
            }

            if (alignContent.HasValue)
            {
                node.AlignContent = alignContent.Value;
            }

            if (alignItems.HasValue)
            {
                node.AlignItems = alignItems.Value;
            }

            if (alignSelf.HasValue)
            {
                node.AlignSelf = alignSelf.Value;
            }

            if (positionType.HasValue)
            {
                node.PositionType = positionType.Value;
            }

            if (wrap.HasValue)
            {
                node.Wrap = wrap.Value;
            }

            if (overflow.HasValue)
            {
                node.Overflow = overflow.Value;
            }

            if (flex.HasValue)
            {
                node.Flex = flex.Value;
            }

            if (flexGrow.HasValue)
            {
                node.FlexGrow = flexGrow.Value;
            }

            if (flexShrink.HasValue)
            {
                node.FlexShrink = flexShrink.Value;
            }

            if (flexBasis.HasValue)
            {
                node.FlexBasis = flexBasis.Value;
            }

            if (position != null)
            {
                if (position.Top.HasValue)
                {
                    node.SetPosition(YogaEdge.Top, position.Top.Value);
                }

                if (position.Bottom.HasValue)
                {
                    node.SetPosition(YogaEdge.Bottom, position.Bottom.Value);
                }

                if (position.Left.HasValue)
                {
                    node.SetPosition(YogaEdge.Left, position.Left.Value);
                }

                if (position.Right.HasValue)
                {
                    node.SetPosition(YogaEdge.Right, position.Right.Value);
                }
            }

            if (margin != null)
            {
                if (margin.Top.HasValue)
                {
                    node.SetMargin(YogaEdge.Top, margin.Top.Value);
                }

                if (margin.Bottom.HasValue)
                {
                    node.SetMargin(YogaEdge.Bottom, margin.Bottom.Value);
                }

                if (margin.Left.HasValue)
                {
                    node.SetMargin(YogaEdge.Left, margin.Left.Value);
                }

                if (margin.Right.HasValue)
                {
                    node.SetMargin(YogaEdge.Right, margin.Right.Value);
                }
            }

            if (padding != null)
            {
                if (padding.Top.HasValue)
                {
                    node.SetPadding(YogaEdge.Top, padding.Top.Value);
                }

                if (padding.Bottom.HasValue)
                {
                    node.SetPadding(YogaEdge.Bottom, padding.Bottom.Value);
                }

                if (padding.Left.HasValue)
                {
                    node.SetPadding(YogaEdge.Left, padding.Left.Value);
                }

                if (padding.Right.HasValue)
                {
                    node.SetPadding(YogaEdge.Right, padding.Right.Value);
                }
            }

            if (border != null)
            {
                if (border.Top.HasValue)
                {
                    node.SetBorder(YogaEdge.Top, border.Top.Value);
                }

                if (border.Bottom.HasValue)
                {
                    node.SetBorder(YogaEdge.Bottom, border.Bottom.Value);
                }

                if (border.Left.HasValue)
                {
                    node.SetBorder(YogaEdge.Left, border.Left.Value);
                }

                if (border.Right.HasValue)
                {
                    node.SetBorder(YogaEdge.Right, border.Right.Value);
                }
            }

            if (width.HasValue)
            {
                node.Width = width.Value;
            }

            if (height.HasValue)
            {
                node.Height = height.Value;
            }

            if (minWidth.HasValue)
            {
                node.MinWidth = minWidth.Value;
            }

            if (minHeight.HasValue)
            {
                node.MinHeight = minHeight.Value;
            }

            if (maxWidth.HasValue)
            {
                node.MaxWidth = maxWidth.Value;
            }

            if (maxHeight.HasValue)
            {
                node.MaxHeight = maxHeight.Value;
            }

            return node;
        }
    }
}
