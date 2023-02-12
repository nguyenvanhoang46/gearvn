import React from 'react'
import InfoTop from '../Gearvninfotop'
import InputSearch from './InputSearch'
import HeaderRight from './HeaderRight'
import Logo from './Login'
import { Link } from 'react-router-dom';
import Category from '../catergory'
import { useRef } from "react";
import { FaBars, FaTimes } from "react-icons/fa";

const Header = () => {
  const navRef = useRef();

  const showNavbar = () => {
    navRef.current.classList.toggle("responsive_nav");
  };
  return (
    <>
      <div className="bg-[#f1f0f1] ">
        <div className="pt-2 pb-2 border-b-[1px] border-[red] border-[#d4d4d4]">
          <div className='container mx-auto'>
            <div className="grid grid-cols-12 gap-4 ">
              <div className="col-span-2">
                <Link className='logo' to='/'>
                  <Logo />
                </Link>
              </div>
              <div className="col-span-10">
                <div className="flex nav-midd items-center">
                  <InputSearch />
                  <HeaderRight />
                </div>
                <InfoTop />
              </div>
            </div>
          </div>
        </div>
      </div>
    </>
  )
}

export default Header
