﻿// SAO : LT
// Copyright (C) wotoTeam, TeaInside, MODAnime Foundation
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of the source code.

namespace SAO.Controls.Elements
{
    public enum ElementMovements
    {
        /// <summary>
        /// That means this Elements should not move at the time 
        /// mouse downed.
        /// </summary>
        NoMovements = 0,
        /// <summary>
        /// This element will move vertical
        /// at the time mouse downed.
        /// </summary>
        VerticalMovements = 1,
        /// <summary>
        /// This element will move Horizontal
        /// at the time mouse downed.
        /// </summary>
        HorizontalMovements = 2,
        /// <summary>
        /// This element will move both vertical and Horizontal
        /// at the time mouse downed.
        /// </summary>
        VerticalHorizontalMovements = 3,
    }
}
