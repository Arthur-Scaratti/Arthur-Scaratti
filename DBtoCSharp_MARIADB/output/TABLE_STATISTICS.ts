export interface TABLE_STATISTICS
    {
        /**///  */
        TABLE_SCHEMA: string;
        /**///  */
        TABLE_NAME: string;
        /**///  */
        ROWS_READ: number;
        /**///  */
        ROWS_CHANGED: number;
        /**///  */
        ROWS_CHANGED_X_INDEXES: number;
}