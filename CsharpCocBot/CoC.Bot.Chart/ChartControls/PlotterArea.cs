﻿/*
 * Modern UI (Metro) Charts for Windows 8, WPF, Silverlight
 * 
 * The charts have been developed by Torsten Mandelkow.
 * http://modernuicharts.codeplex.com/
 */

namespace CoC.Bot.Chart
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Windows.Controls;
	using System.Windows;

    public class PlotterArea : ContentControl
    {
        public static readonly DependencyProperty DataPointItemTemplateProperty =
            DependencyProperty.Register("DataPointItemTemplate",
            typeof(DataTemplate),
            typeof(PlotterArea),
            new PropertyMetadata(null));

        public static readonly DependencyProperty DataPointItemsPanelProperty =
            DependencyProperty.Register("DataPointItemsPanel",
            typeof(ItemsPanelTemplate),
            typeof(PlotterArea),
            new PropertyMetadata(null));

        public static readonly DependencyProperty ChartLegendItemStyleProperty =
            DependencyProperty.Register("ChartLegendItemStyle",
            typeof(Style),
            typeof(PlotterArea),
            new PropertyMetadata(null));

        public static readonly DependencyProperty ParentChartProperty =
            DependencyProperty.Register("ParentChart",
            typeof(ChartBase),
            typeof(PlotterArea),
            new PropertyMetadata(null));

        static PlotterArea()
        {
			DefaultStyleKeyProperty.OverrideMetadata(typeof(PlotterArea), new FrameworkPropertyMetadata(typeof(PlotterArea)));
        }

        public PlotterArea()
        {

        }
        
        public Style ChartLegendItemStyle
        {
            get { return (Style)GetValue(ChartLegendItemStyleProperty); }
            set { SetValue(ChartLegendItemStyleProperty, value); }
        }

        public DataTemplate DataPointItemTemplate
        {
            get { return (DataTemplate)GetValue(DataPointItemTemplateProperty); }
            set { SetValue(DataPointItemTemplateProperty, value); }
        }

        public ItemsPanelTemplate DataPointItemsPanel
        {
            get { return (ItemsPanelTemplate)GetValue(DataPointItemsPanelProperty); }
            set { SetValue(DataPointItemsPanelProperty, value); }
        }

        public ChartBase ParentChart
        {
            get { return (ChartBase)GetValue(ParentChartProperty); }
            set { SetValue(ParentChartProperty, value); }
        }
    }
}
