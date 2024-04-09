export interface THREAD_POOL_STATS
    {
        /**///  */
        GROUP_ID: number;
        /**///  */
        THREAD_CREATIONS: number;
        /**///  */
        THREAD_CREATIONS_DUE_TO_STALL: number;
        /**///  */
        WAKES: number;
        /**///  */
        WAKES_DUE_TO_STALL: number;
        /**///  */
        THROTTLES: number;
        /**///  */
        STALLS: number;
        /**///  */
        POLLS_BY_LISTENER: number;
        /**///  */
        POLLS_BY_WORKER: number;
        /**///  */
        DEQUEUES_BY_LISTENER: number;
        /**///  */
        DEQUEUES_BY_WORKER: number;
}