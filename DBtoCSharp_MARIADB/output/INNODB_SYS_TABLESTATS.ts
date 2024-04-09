export interface INNODB_SYS_TABLESTATS
    {
        /**///  */
        TABLE_ID: number;
        /**///  */
        NAME: string;
        /**///  */
        STATS_INITIALIZED: number;
        /**///  */
        NUM_ROWS: number;
        /**///  */
        CLUST_INDEX_SIZE: number;
        /**///  */
        OTHER_INDEX_SIZE: number;
        /**///  */
        MODIFIED_COUNTER: number;
        /**///  */
        AUTOINC: number;
        /**///  */
        REF_COUNT: number;
}