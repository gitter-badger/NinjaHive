﻿using NinjaHive.Contract.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace NinjaHive.WebApp.Areas.Items.Models
{
    public interface IGameItemViewModel
    {
        GameItemModel Item { get; }

        IEnumerable<SelectListItem> Categories { get; }
    }

    public interface IGameItemViewModel<TItem> : IGameItemViewModel
        where TItem : GameItemModel
    {
        TItem DerivedItem { get; }
    }
}
