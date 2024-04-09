export interface INNODB_CMP_PER_INDEX_RESET
    {
        /**///  */
        database_name: string;
        /**///  */
        table_name: string;
        /**///  */
        index_name: string;
        /**///  */
        compress_ops: number;
        /**///  */
        compress_ops_ok: number;
        /**///  */
        compress_time: number;
        /**///  */
        uncompress_ops: number;
        /**///  */
        uncompress_time: number;
}