export interface Season {
    id: number;
    edition: number;
    champion: string | null;
    subChampion: string | null;
    tournamentId: number;
    tournament: {
    $ref: string;
    } | null;
}