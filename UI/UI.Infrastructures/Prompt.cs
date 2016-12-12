﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Infrastructures
{
    /// <summary>
    /// 提示
    /// </summary>
    public class Prompt
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 消息
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 按钮组
        /// </summary>
        public List<string> Buttons { get; set; }
    }
}
