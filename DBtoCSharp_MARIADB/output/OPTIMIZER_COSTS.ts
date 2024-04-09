export interface OPTIMIZER_COSTS
    {
        /**///  */
        ENGINE: string;
        /**///  */
        OPTIMIZER_DISK_READ_COST: number;
        /**///  */
        OPTIMIZER_INDEX_BLOCK_COPY_COST: number;
        /**///  */
        OPTIMIZER_KEY_COMPARE_COST: number;
        /**///  */
        OPTIMIZER_KEY_COPY_COST: number;
        /**///  */
        OPTIMIZER_KEY_LOOKUP_COST: number;
        /**///  */
        OPTIMIZER_KEY_NEXT_FIND_COST: number;
        /**///  */
        OPTIMIZER_DISK_READ_RATIO: number;
        /**///  */
        OPTIMIZER_ROW_COPY_COST: number;
        /**///  */
        OPTIMIZER_ROW_LOOKUP_COST: number;
        /**///  */
        OPTIMIZER_ROW_NEXT_FIND_COST: number;
        /**///  */
        OPTIMIZER_ROWID_COMPARE_COST: number;
        /**///  */
        OPTIMIZER_ROWID_COPY_COST: number;
}