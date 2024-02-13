import { Season } from "./Season";

export interface Tournament {
    id: number;
    name: string;
    logo: string;
    flag: string;
    seasons: {
        $id: string;
        $values: Season[];
    };
}