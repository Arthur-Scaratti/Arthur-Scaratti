export interface THREAD_POOL_GROUPS
    {
        /**///  */
        GROUP_ID: number;
        /**///  */
        CONNECTIONS: number;
        /**///  */
        THREADS: number;
        /**///  */
        ACTIVE_THREADS: number;
        /**///  */
        STANDBY_THREADS: number;
        /**///  */
        QUEUE_LENGTH: number;
        /**///  */
        HAS_LISTENER: number;
        /**///  */
        IS_STALLED: number;
}