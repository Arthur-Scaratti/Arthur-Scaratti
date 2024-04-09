export interface TABLESPACES
    {
        /**///  */
        TABLESPACE_NAME: string;
        /**///  */
        ENGINE: string;
        /**///  */
        TABLESPACE_TYPE: string;
        /**///  */
        LOGFILE_GROUP_NAME: string;
        /**///  */
        EXTENT_SIZE: number;
        /**///  */
        AUTOEXTEND_SIZE: number;
        /**///  */
        MAXIMUM_SIZE: number;
        /**///  */
        NODEGROUP_ID: number;
        /**///  */
        TABLESPACE_COMMENT: string;
}