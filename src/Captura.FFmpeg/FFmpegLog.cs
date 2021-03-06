﻿using System.Collections.ObjectModel;

namespace Captura.Models
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class FFmpegLog : NotifyPropertyChanged
    {
        public FFmpegLog()
        {
            LogItems = new ReadOnlyObservableCollection<FFmpegLogItem>(_logItems);
        }

        readonly ObservableCollection<FFmpegLogItem> _logItems = new ObservableCollection<FFmpegLogItem>();

        public ReadOnlyObservableCollection<FFmpegLogItem> LogItems { get; }

        public FFmpegLogItem CreateNew(string Name, string Args)
        {
            var item = new FFmpegLogItem(Name, Args);

            _logItems.Insert(0, item);

            return item;
        }

        public void Remove(FFmpegLogItem Item)
        {
            _logItems.Remove(Item);
        }
    }
}
