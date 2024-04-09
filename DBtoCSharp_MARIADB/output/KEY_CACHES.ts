export interface KEY_CACHES
    {
        /**///  */
        KEY_CACHE_NAME: string;
        /**///  */
        SEGMENTS: number;
        /**///  */
        SEGMENT_NUMBER: number;
        /**///  */
        FULL_SIZE: number;
        /**///  */
        BLOCK_SIZE: number;
        /**///  */
        USED_BLOCKS: number;
        /**///  */
        UNUSED_BLOCKS: number;
        /**///  */
        DIRTY_BLOCKS: number;
        /**///  */
        READ_REQUESTS: number;
        /**///  */
        READS: number;
        /**///  */
        WRITE_REQUESTS: number;
        /**///  */
        WRITES: number;
}