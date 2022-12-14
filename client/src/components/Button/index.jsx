import React from 'react'

const Button = ({icon,label}) => {
  return (
    <div className='flex gap-2 items-center text-[11px] font-bold'>
        {icon}
        {label}
      </div>
  )
}

export default Button
