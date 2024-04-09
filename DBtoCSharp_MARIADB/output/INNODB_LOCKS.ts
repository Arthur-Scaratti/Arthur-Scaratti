export interface INNODB_LOCKS
    {
        /**///  */
        lock_id: string;
        /**///  */
        lock_trx_id: number;
        /**///  */
        lock_mode: string;
        /**///  */
        lock_type: string;
        /**///  */
        lock_table: string;
        /**///  */
        lock_index: string;
        /**///  */
        lock_space: number;
        /**///  */
        lock_page: number;
        /**///  */
        lock_rec: number;
        /**///  */
        lock_data: string;
}