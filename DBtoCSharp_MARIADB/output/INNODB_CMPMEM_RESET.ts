export interface INNODB_CMPMEM_RESET
    {
        /**///  */
        page_size: number;
        /**///  */
        buffer_pool_instance: number;
        /**///  */
        pages_used: number;
        /**///  */
        pages_free: number;
        /**///  */
        relocation_ops: number;
        /**///  */
        relocation_time: number;
}