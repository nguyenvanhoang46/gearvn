import React from 'react'
import { Link } from 'react-router-dom'
import { AiFillSetting } from 'react-icons/ai'
import { MdNotifications } from 'react-icons/md'
import { FaUserCircle } from 'react-icons/fa'


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
                <div className="flex">
                    <div className="mr-auto md:mr-4 md:w-56">
                        <div className="relative w-full min-w-[200px] h-10">
                            <input class="caret-[#B0BEC5] peer w-full h-full bg-transparent  font-sans font-normal outline outline-0 focus:outline-0 disabled:bg-blue-gray-50 disabled:border-0 transition-all placeholder-shown:border placeholder-shown:border-blue-gray-200 placeholder-shown:border-t-blue-gray-200 border focus:border-2 border-t-transparent focus:border-t-transparent text-sm px-3 py-2.5 rounded-[7px] border-blue-gray-200 focus:border-blue-500" placeholder=" " />
                            <label class="flex w-full h-full select-none pointer-events-none absolute left-0 font-normal peer-placeholder-shown:text-blue-gray-500 leading-tight peer-focus:leading-tight peer-disabled:text-transparent peer-disabled:peer-placeholder-shown:text-blue-gray-500 transition-all -top-1.5 peer-placeholder-shown:text-sm text-[11px] peer-focus:text-[11px] before:content[' '] before:block before:box-border before:w-2.5 before:h-1.5 before:mt-[6.5px] before:mr-1 peer-placeholder-shown:before:border-transparent before:rounded-tl-md before:border-t peer-focus:before:border-t-2 before:border-l peer-focus:before:border-l-2 before:pointer-events-none before:transition-all peer-disabled:before:border-transparent after:content[' '] after:block after:flex-grow after:box-border after:w-2.5 after:h-1.5 after:mt-[6.5px] after:ml-1 peer-placeholder-shown:after:border-transparent after:rounded-tr-md after:border-t peer-focus:after:border-t-2 after:border-r peer-focus:after:border-r-2 after:pointer-events-none after:transition-all peer-disabled:after:border-transparent peer-placeholder-shown:leading-[3.75] text-blue-gray-400 peer-focus:text-blue-500 before:border-blue-gray-200 peer-focus:before:border-blue-500 after:border-blue-gray-200 peer-focus:after:border-blue-500">Type here</label>
                        </div>
                    </div>
                    <div className="middle none font-sans font-bold center uppercase transition-all disabled:opacity-50 disabled:shadow-none disabled:pointer-events-none text-xs py-3 rounded-lg text-blue-gray-500 hover:bg-blue-gray-500/10 active:bg-blue-gray-500/30 hidden items-center gap-1 px-4 xl:flex">
                        <Link to='/adminlogin' className='flex gap-2 items-center' >
                            <FaUserCircle className='h-5 w-5 text-[#607D8B] ' />
                            <span className='text-[#607D8B] uppercase'>Sign in</span>
                        </Link>
                    </div>
                    <button className='middle none font-sans font-bold center uppercase transition-all disabled:opacity-50 disabled:shadow-none disabled:pointer-events-none text-xs py-3 rounded-lg text-blue-gray-500 hover:bg-blue-gray-500/10 active:bg-blue-gray-500/30 hidden items-center gap-1 px-4 xl:flex'>
                        <AiFillSetting className='h-5 w-5 text-[#607D8B] ' />
                    </button>
                    <button className='middle none font-sans font-bold center uppercase transition-all disabled:opacity-50 disabled:shadow-none disabled:pointer-events-none text-xs py-3 rounded-lg text-blue-gray-500 hover:bg-blue-gray-500/10 active:bg-blue-gray-500/30 hidden items-center gap-1 px-4 xl:flex'>
                        <MdNotifications className='h-5 w-5 text-[#607D8B] ' />
                    </button>
                </div>
            </div>
        </>  
    )
}

export default NavbarTop