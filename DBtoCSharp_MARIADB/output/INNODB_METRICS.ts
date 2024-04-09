export interface INNODB_METRICS
    {
        /**///  */
        NAME: string;
        /**///  */
        SUBSYSTEM: string;
        /**///  */
        COUNT: number;
        /**///  */
        MAX_COUNT: number;
        /**///  */
        MIN_COUNT: number;
        /**///  */
        AVG_COUNT: number;
        /**///  */
        COUNT_RESET: number;
        /**///  */
        MAX_COUNT_RESET: number;
        /**///  */
        MIN_COUNT_RESET: number;
        /**///  */
        AVG_COUNT_RESET: number;
        /**///  */
        TIME_ENABLED: string;
        /**///  */
        TIME_DISABLED: string;
        /**///  */
        TIME_ELAPSED: number;
        /**///  */
        TIME_RESET: string;
        /**///  */
        ENABLED: number;
        /**///  */
        TYPE: string;
        /**///  */
        COMMENT: string;
}