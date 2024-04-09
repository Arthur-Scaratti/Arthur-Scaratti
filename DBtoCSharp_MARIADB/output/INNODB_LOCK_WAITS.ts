export interface INNODB_LOCK_WAITS
    {
        /**///  */
        requesting_trx_id: number;
        /**///  */
        requested_lock_id: string;
        /**///  */
        blocking_trx_id: number;
        /**///  */
        blocking_lock_id: string;
}