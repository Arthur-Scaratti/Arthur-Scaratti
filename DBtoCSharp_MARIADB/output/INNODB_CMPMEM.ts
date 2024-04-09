export interface INNODB_CMPMEM
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