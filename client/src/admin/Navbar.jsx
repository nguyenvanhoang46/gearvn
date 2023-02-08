import React, { useState } from 'react'
import { Link } from 'react-router-dom'
import { FaHome } from 'react-icons/fa';
import { SiInstructables } from 'react-icons/si';

const Navbar = () => {

    const [active, setActive] = useState(null);


    const handleClick = () => {

    }
    return (
        <>
            <div className="">
                <div className="w-72 bg-[#263238] rounded-xl ml-4 my-4 fixed inset-0 z-50">
                    <div className="relative border-b border-white/20 ">
                        <Link className='px-8 py-6 gap-4 items-center flex uppercase ' to="/">
                            <h6 className='text-white font-semibold leading-relaxed '>Nguyễn Văn Hoàng</h6>
                        </Link>
                    </div>
                    <div className="">
                        <ul className='py-3 px-4'>
                            <li>
                                <Link className='active' onClick={() => setActive()} to='/tableproduct'>
                                    <button className='middle none font-sans font-bold center transition-all disabled:opacity-50 disabled:shadow-none disabled:pointer-events-none text-xs py-3 rounded-lg bg-gradient-to-tr from-blue-600 to-blue-400 text-white shadow-md shadow-blue-500/20 hover:shadow-lg hover:shadow-blue-500/40 active:opacity-[0.85] w-full flex items-center gap-4 px-4 capitalize'>
                                        <SiInstructables className='text-[20px]' />
                                        <p className='block antialiased font-sans text-base leading-relaxed text-inherit font-medium capitalize'>Product</p>
                                    </button>
                                </Link>
                            </li>
                            <li className='mt-10'>
                                <Link className='active' to='/tableuser'>
                                    <button className='middle none font-sans font-bold center transition-all disabled:opacity-50 disabled:shadow-none disabled:pointer-events-none text-xs py-3 rounded-lg bg-gradient-to-tr from-blue-600 to-blue-400 text-white shadow-md shadow-blue-500/20 hover:shadow-lg hover:shadow-blue-500/40 active:opacity-[0.85] w-full flex items-center gap-4 px-4 capitalize'>
                                        <SiInstructables className='text-[20px]' />
                                        <p className='block antialiased font-sans text-base leading-relaxed text-inherit font-medium capitalize'>User</p>
                                    </button>
                                </Link>
                            </li>
                            <li className='mt-10'>
                                <Link className='active' to='/tablecategory'>
                                    <button className='middle none font-sans font-bold center transition-all disabled:opacity-50 disabled:shadow-none disabled:pointer-events-none text-xs py-3 rounded-lg bg-gradient-to-tr from-blue-600 to-blue-400 text-white shadow-md shadow-blue-500/20 hover:shadow-lg hover:shadow-blue-500/40 active:opacity-[0.85] w-full flex items-center gap-4 px-4 capitalize'>
                                        <SiInstructables className='text-[20px]' />
                                        <p className='block antialiased font-sans text-base leading-relaxed text-inherit font-medium capitalize'>Category</p>
                                    </button>
                                </Link>
                            </li>
                        </ul>
                    </div>
                    <div className="mx-3.5 mt-4 mb-2">
                        <p className="block antialiased font-sans text-sm leading-normal text-white font-black uppercase opacity-75">auth pages</p>
                    </div>
                    <ul className='py-3 px-4'>
                        <li>
                            <Link to='/'>
                                <div className='text-white bg-[#42a5f5] font-bold text-[15px] capitalize rounded-lg gap-4 items-center w-full flex py-3 px-4 shadow-blue-500/20 '>
                                    <FaHome className='text-[20px]' />
                                    <p>dashboard</p>
                                </div>
                            </Link>
                        </li>
                    </ul>
                </div>
            </div>
        </>
    )
}

export default Navbar;