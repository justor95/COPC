﻿namespace COPC.ContractModels
{
    /// <summary>
    /// 合约事件接口
    /// </summary>
    public interface IContractEvent
    {
        /// <summary>
        /// 唯一标识Id
        /// </summary>
        string Id { get; set; }
        /// <summary>
        /// 合约事件数据
        /// </summary>
        IContractEventData ContractEventData { get; set; }
        /// <summary>
        /// 克隆
        /// </summary>
        IContractEvent Clone();
    }
}
