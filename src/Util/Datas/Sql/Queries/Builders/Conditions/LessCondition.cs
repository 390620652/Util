﻿namespace Util.Datas.Sql.Queries.Builders.Conditions {
    /// <summary>
    /// Sql小于查询条件
    /// </summary>
    public class LessCondition : ICondition {
        /// <summary>
        /// 列名
        /// </summary>
        private readonly string _column;
        /// <summary>
        /// 参数
        /// </summary>
        private readonly string _parameter;

        /// <summary>
        /// 初始化Sql小于查询条件
        /// </summary>
        /// <param name="column">列名</param>
        /// <param name="parameter">参数</param>
        public LessCondition( string column, string parameter ) {
            _column = column;
            _parameter = parameter;
        }

        /// <summary>
        /// 获取查询条件
        /// </summary>
        public string GetCondition() {
            return $"{_column}<{_parameter}";
        }
    }
}