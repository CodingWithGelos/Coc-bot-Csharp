﻿namespace CoC.Bot.UI.Interactivity
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class TriggerActionCollection : AttachableCollection<TriggerAction>
	{
		internal TriggerActionCollection()
		{
		}

		protected override System.Windows.Freezable CreateInstanceCore()
		{
			return new TriggerActionCollection();
		}

		internal override void ItemAdded(TriggerAction item)
		{
			if (item.IsHosted)
			{
				throw new InvalidOperationException(Properties.Resources.CannotHostTriggerActionMultipleTimesExceptionMessage);
			}
			if (AssociatedObject != null)
			{
				item.Attach(AssociatedObject);
			}
			item.IsHosted = true;
		}

		internal override void ItemRemoved(TriggerAction item)
		{
			if (((IAttachedObject)item).AssociatedObject != null)
			{
				item.Detach();
			}
			item.IsHosted = false;
		}

		protected override void OnAttached()
		{
			foreach (TriggerAction action in this)
			{
				action.Attach(AssociatedObject);
			}
		}

		protected override void OnDetaching()
		{
			foreach (TriggerAction action in this)
			{
				action.Detach();
			}
		}
	}
}