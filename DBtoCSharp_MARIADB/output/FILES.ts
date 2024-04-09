export interface FILES
    {
        /**///  */
        FILE_ID: number;
        /**///  */
        FILE_NAME: string;
        /**///  */
        FILE_TYPE: string;
        /**///  */
        TABLESPACE_NAME: string;
        /**///  */
        TABLE_CATALOG: string;
        /**///  */
        TABLE_SCHEMA: string;
        /**///  */
        TABLE_NAME: string;
        /**///  */
        LOGFILE_GROUP_NAME: string;
        /**///  */
        LOGFILE_GROUP_NUMBER: number;
        /**///  */
        ENGINE: string;
        /**///  */
        FULLTEXT_KEYS: string;
        /**///  */
        DELETED_ROWS: number;
        /**///  */
        UPDATE_COUNT: number;
        /**///  */
        FREE_EXTENTS: number;
        /**///  */
        TOTAL_EXTENTS: number;
        /**///  */
        EXTENT_SIZE: number;
        /**///  */
        INITIAL_SIZE: number;
        /**///  */
        MAXIMUM_SIZE: number;
        /**///  */
        AUTOEXTEND_SIZE: number;
        /**///  */
        CREATION_TIME: string;
        /**///  */
        LAST_UPDATE_TIME: string;
        /**///  */
        LAST_ACCESS_TIME: string;
        /**///  */
        RECOVER_TIME: number;
        /**///  */
        TRANSACTION_COUNTER: number;
        /**///  */
        VERSION: number;
        /**///  */
        ROW_FORMAT: string;
        /**///  */
        TABLE_ROWS: number;
        /**///  */
        AVG_ROW_LENGTH: number;
        /**///  */
        DATA_LENGTH: number;
        /**///  */
        MAX_DATA_LENGTH: number;
        /**///  */
        INDEX_LENGTH: number;
        /**///  */
        DATA_FREE: number;
        /**///  */
        CREATE_TIME: string;
        /**///  */
        UPDATE_TIME: string;
        /**///  */
        CHECK_TIME: string;
        /**///  */
        CHECKSUM: number;
        /**///  */
        STATUS: string;
        /**///  */
        EXTRA: string;
}