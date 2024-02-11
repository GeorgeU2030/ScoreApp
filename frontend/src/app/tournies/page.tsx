import NavBar from '@/components/NavBar'
import React from 'react'

export default function page() {
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
            </section>
        </div>
    </div>
  )
}
