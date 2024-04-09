export interface INNODB_TABLESPACES_ENCRYPTION
    {
        /**///  */
        SPACE: number;
        /**///  */
        NAME: string;
        /**///  */
        ENCRYPTION_SCHEME: number;
        /**///  */
        KEYSERVER_REQUESTS: number;
        /**///  */
        MIN_KEY_VERSION: number;
        /**///  */
        CURRENT_KEY_VERSION: number;
        /**///  */
        KEY_ROTATION_PAGE_NUMBER: number;
        /**///  */
        KEY_ROTATION_MAX_PAGE_NUMBER: number;
        /**///  */
        CURRENT_KEY_ID: number;
        /**///  */
        ROTATING_OR_FLUSHING: number;
}