export interface INNODB_SYS_TABLESPACES
    {
        /**///  */
        SPACE: number;
        /**///  */
        NAME: string;
        /**///  */
        FLAG: number;
        /**///  */
        ROW_FORMAT: string;
        /**///  */
        PAGE_SIZE: number;
        /**///  */
        FILENAME: string;
        /**///  */
        FS_BLOCK_SIZE: number;
        /**///  */
        FILE_SIZE: number;
        /**///  */
        ALLOCATED_SIZE: number;
}