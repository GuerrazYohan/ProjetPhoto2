<?php

namespace App\Entity;

use ApiPlatform\Core\Annotation\ApiResource as ApiResource;
use Doctrine\ORM\Mapping as ORM;

/**
 * Photo
 *
 * @ORM\Table(name="photo")
 * @ApiResource
 * @ORM\Entity
 */
class Photo
{
    /**
     * @var int
     *
     * @ORM\Column(name="idPhoto", type="integer", nullable=false)
     * @ORM\Id
     * @ORM\GeneratedValue(strategy="IDENTITY")
     */
    private $idphoto;

    /**
     * @var string
     *
     * @ORM\Column(name="CheminDacces", type="string", length=200, nullable=false)
     */
    private $chemindacces;

    /**
     * @var string
     *
     * @ORM\Column(name="RawBytesQR", type="string", length=500, nullable=false)
     */
    private $rawbytesqr;

    public function getIdphoto(): ?int
    {
        return $this->idphoto;
    }

    public function getChemindacces(): ?string
    {
        return $this->chemindacces;
    }

    public function setChemindacces(string $chemindacces): self
    {
        $this->chemindacces = $chemindacces;

        return $this;
    }

    public function getRawbytesqr(): ?string
    {
        return $this->rawbytesqr;
    }

    public function setRawbytesqr(string $rawbytesqr): self
    {
        $this->rawbytesqr = $rawbytesqr;

        return $this;
    }


}
