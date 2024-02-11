'use client'
import NavBar from '@/components/NavBar';
import { Tournament } from '@/interfaces/Tournament';
import { useParams } from 'next/navigation';
import { useEffect,useState } from 'react';
import { Button } from '@nextui-org/react';
import { PlusCircle } from 'lucide-react';

const TournamentDetailPage = () => {
  const id = useParams().id;

  const [tournament,setTournament] = useState<Tournament | null>(null); 

  useEffect(() => {
    const fetchTournaments = async () => {
      try {
        const response = await fetch(`${process.env.NEXT_PUBLIC_API_URL}Tournament/GetTournament/${id}`); 
        const data = await response.json();
        setTournament(data);
      } catch (error) {
        console.error('Error:', error);
      }
    };
  
    fetchTournaments();
  }, []);

  const createSeason = async () => {
    try {
      const response = await fetch(`${process.env.NEXT_PUBLIC_API_URL}Season/AddSeason/${id}`,
      {
        method:'POST',
      }); 
      const data = await response.json();
    } catch (error) {
      console.error('Error:', error);
    }
  };

  return (
    <div>
      <NavBar />
      <div className='flex flex-col items-center'>
      <div className='w-4/6 flex justify-between items-center mt-8 py-1'>
      <img src={tournament?.logoTournament} className='w-12 h-12 ml-4 bg-[#f2f2f2] rounded-lg px-1'></img>
      <h1 className='font-semibold ml-4'>{tournament?.nameTournament}</h1>
      <div >
        <Button startContent={<PlusCircle />} className='bg-teal-600 hover:bg-teal-500'
        onClick={createSeason}>
          New season
        </Button>
      </div>
      </div>
      </div>
    </div>
  );
};

export default TournamentDetailPage;
