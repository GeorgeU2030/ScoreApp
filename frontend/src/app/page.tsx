'use client'
import NavBar from "@/components/NavBar";
import { Button } from "@nextui-org/react";
import { Trophy } from "lucide-react";
import { useRouter } from "next/navigation";

export default function Home() {

  const router = useRouter();

  return (
    <div>
     <NavBar />
    <div className="flex flex-col items-center">
    <section className="w-3/4 flex">
      <div className="w-1/2 mt-8">
        <img className="h-64" src="https://cnnespanol.cnn.com/wp-content/uploads/2023/06/GettyImages-1258593002-e1686432159344.jpg?quality=100&strip=info"></img>     
      </div>
      <div className="w-1/2 mt-8 flex justify-center">
       <img className="h-64" src="https://phantom-marca.unidadeditorial.es/2a9f3a151346f7d194aae4b68016ddcc/crop/0x0/2044x1363/resize/828/f/jpg/assets/multimedia/imagenes/2023/06/13/16866405437920.jpg"></img>
      </div>
    </section>
    <section className="w-3/4 flex">
      <div className="w-1/2 mt-8">
        <img className="h-64" src="https://cnnespanol.cnn.com/wp-content/uploads/2023/07/alcaraz-djokovic-wimbledon-2023.jpg?quality=100&strip=info"></img>     
      </div>
      <div className="w-1/2 mt-8 flex justify-center">
       <img className="h-64" src="https://media-cldnry.s-nbcnews.com/image/upload/t_fit-760w,f_auto,q_auto:best/rockcms/2023-02/230212-super-bowl-trophy-jm-2250-826237.jpg"></img>
      </div>
    </section>
    <section className="w-3/4 flex mb-12">
      <div className="w-1/2 mt-8">
        <img className="h-64" src="https://media.rpctv.com/p/69924cf2c8933d2c529ab2188f6e5496/adjuntos/314/imagenes/018/434/0018434385/1200x675/smart/000_33xq7jujpg.jpg"></img>     
      </div>
      <div className="w-1/2 mt-8 flex flex-col justify-center items-center ">
        <h1 className="mb-4 font-bold">SeasonApp</h1>
        <h3 className="mb-4">Soccer, Basketball, Tennis, Football, F1</h3>
      <Button className="bg-[#23c7d987] hover:bg-[#23C7D9]" startContent={<Trophy />}
      onClick={() => router.push('/tournies')}
      >
      Tournies
      </Button>
      </div>
    </section>
    </div>
    </div>
  );
}
