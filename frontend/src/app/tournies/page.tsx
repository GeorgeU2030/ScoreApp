'use client'
import NavBar from '@/components/NavBar'
import { Tournament } from '@/interfaces/Tournament';
import { useEffect,useState } from 'react'
import Link from 'next/link';

export default function page() {

  const [tournaments,setTournaments] = useState<Tournament[]>([])

  useEffect(() => {
    const fetchTournaments = async () => {
      try {
        const response = await fetch(`${process.env.NEXT_PUBLIC_API_URL}Tournament/GetTournaments`); 
        const data = await response.json();
        setTournaments(data);
      } catch (error) {
        console.error('Error:', error);
      }
    };
  
    fetchTournaments();
  }, []);

  console.log(tournaments)
  return (
    <div>
        <NavBar />
        <div className='flex flex-col items-center'>
            <section className='w-5/6 flex flex-col'>
                <div className='flex justify-center'>
                <h1 className='text-4xl mt-4'>Tournies</h1>
                </div>
                <div className='mt-5'>
                    <h1 className='ml-6'>Soccer</h1>
                </div>
                <div className='mt-5 grid grid-cols-5 '>
                  {tournaments.map((tournament) => (
                    <Link href={`/tournies/${tournament.tournamentId}`}>
                    <div key={tournament.tournamentId} className='ml-6 bg-[#f2f2f2] border-2 border-[#23C7D9] flex flex-col items-center rounded-lg'
                    >  
                      <img src={tournament.logoTournament} className='w-24 h-24 mt-4'></img>
                      <h1 className='text-teal-800 mt-2'>{tournament.nameTournament}</h1>
                      <img src={tournament.flag} className='w-8 h-4 mt-2'></img>
                    </div>
                    </Link>
                  ))}
                </div>  
            </section>
        </div>
    </div>
  )
}
