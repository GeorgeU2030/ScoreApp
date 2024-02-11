import { Season } from "./Season";

export interface Tournament {
    tournamentId: number;
    nameTournament: string;
    logoTournament: string;
    flag: string;
    season: Season[];
}