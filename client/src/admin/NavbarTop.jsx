import React from 'react'

const NavbarTop = () => {
    return (
        <>
            <div className="flex flex-col-reverse justify-between gap-6 md:flex-row md:items-center">
                <div className="capitalize">
                    <p className='flex'>
                        <span className='mr-4 block antialiased font-sans text-[16px] leading-normal text-blue-gray-900 font-normal opacity-50 transition-all hover:text-blue-500 hover:opacity-100'> Dashboard</span>
                        <span> </span>
                        <span className='block antialiased font-sans text-[16px] leading-normal text-blue-gray-900 font-normal'>Product</span>
                    </p>
                </div>
                
            </div>
        </>
    )
}

export default NavbarTop