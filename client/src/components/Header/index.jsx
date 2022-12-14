import React from 'react'
import InfoTop from '../Gearvninfotop'
import InputSearch from './InputSearch'
import HeaderRight from './HeaderRight'
import Logo from './Login'
import { Link } from 'react-router-dom';
const Header = () => {
  return (
    <>
        <div className='container mx-auto'>
            <div className="grid grid-cols-12 gap-4 ">
            <div className="col-span-2">
               <Link to='/gearvn'>
                  <Logo />               
               </Link>
            </div>
            <div className="col-span-10">
              <div className="flex items-center">
                <InputSearch />
                <HeaderRight />
              </div>
                <InfoTop />
            </div>
        </div>
    </div>     
    </>
  )
}

export default Header
